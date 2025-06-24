using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicomtic_manegment_system.contoler;
using Unicomtic_manegment_system.controller;
using Unicomtic_manegment_system.model;

namespace Unicomtic_manegment_system.view
{
    public partial class timetable : Form
    {
        public timetable()

        {
            InitializeComponent();
            currentWeekStart = DateTime.Today;
            this.dataGridViewTimetable.DataError += DataGridViewTimetable_DataError;
        }

        private DateTime currentWeekStart;

        string[] timeSlots = new string[]
        {
            "9.00am - 10.30am",
            "10.30am - 12.00pm",
            "12.00pm - 1.00pm (Lunch)",
            "1.00pm - 2.30pm",
            "2.30pm - 4.00pm"
        };



        private void timetable_Load(object sender, EventArgs e)
        {
            SetupTimetableGrid();
            LoadWeek(currentWeekStart);
        }

        private void DataGridViewTimetable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private List<string> GetAllSubjects()
        {
            subjectcontoler subjectController = new subjectcontoler();
            return subjectController.GetSubjects();
        }

        private void SetupTimetableGrid()
        {
            if (dataGridViewTimetable.Columns.Count > 0) return;

            // Hidden Id column for DB record id
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "Id",
                Visible = false
            };
            dataGridViewTimetable.Columns.Add(idColumn);

            dataGridViewTimetable.Columns.Add("Date", "Date");
            dataGridViewTimetable.Columns.Add("Day", "Day");
            dataGridViewTimetable.Columns.Add("Time", "Time");

            // Session ComboBox
            DataGridViewComboBoxColumn sessionColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Session",
                Name = "Session"
            };
            sessionColumn.Items.Add("-- Select --");
            sessionColumn.Items.AddRange("A", "B", "Lunch", "Holiday");

            // Lab ComboBox
            DataGridViewComboBoxColumn labColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Lab",
                Name = "Lab"
            };
            labColumn.Items.Add("-- Select --");
            labColumn.Items.AddRange("A", "B", "Lunch", "Holiday");

            // Subject ComboBox
            DataGridViewComboBoxColumn subjectColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Session Subject",
                Name = "SessionSubject"
            };
            List<string> subjectList = GetAllSubjects();
            subjectList.Insert(0, "-- Select --");
            subjectList.Add("Lunch");
            subjectColumn.Items.AddRange(subjectList.ToArray());

            dataGridViewTimetable.Columns.Add(sessionColumn);
            dataGridViewTimetable.Columns.Add(labColumn);
            dataGridViewTimetable.Columns.Add(subjectColumn);

            dataGridViewTimetable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadWeek(DateTime startDate)
        {
            SetupEmptyWeekGrid(startDate);
            LoadSavedTimetable(startDate);
        }

        private void SetupEmptyWeekGrid(DateTime startDate)
        {
            dataGridViewTimetable.Rows.Clear();

            for (int dayOffset = 0; dayOffset < 7; dayOffset++)
            {
                DateTime date = startDate.AddDays(dayOffset);
                string dayName = date.ToString("dddd");
                string dateStr = date.ToString("dd.MM.yyyy");

                for (int i = 0; i < timeSlots.Length; i++)
                {
                    int index = dataGridViewTimetable.Rows.Add();
                    var row = dataGridViewTimetable.Rows[index];

                    row.Cells["Date"].Value = i == 0 ? dateStr : "";
                    row.Cells["Day"].Value = i == 0 ? dayName : "";
                    row.Cells["Time"].Value = timeSlots[i];

                    bool isLunch = timeSlots[i].Contains("Lunch");
                    if (isLunch)
                    {
                        row.Cells["Session"].Value = "Lunch";
                        row.Cells["Lab"].Value = "Lunch";
                        row.Cells["SessionSubject"].Value = "Lunch";

                        row.Cells["Session"].ReadOnly = true;
                        row.Cells["Lab"].ReadOnly = true;
                        row.Cells["SessionSubject"].ReadOnly = true;

                        row.Cells["Session"].Style.BackColor = Color.LightGray;
                        row.Cells["Lab"].Style.BackColor = Color.LightGray;
                        row.Cells["SessionSubject"].Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        row.Cells["Session"].Value = "-- Select --";
                        row.Cells["Lab"].Value = "-- Select --";
                        row.Cells["SessionSubject"].Value = "-- Select --";
                    }
                }
            }
        }

        private void LoadSavedTimetable(DateTime weekStart)
        {
            TimetableController controller = new TimetableController();
            List<Timetable> savedTimetables = controller.GetTimetableForWeek(weekStart);

            foreach (var t in savedTimetables)
            {
                // Find matching row by date + time (you may need to improve matching logic if multiple rows have same date/time)
                foreach (DataGridViewRow row in dataGridViewTimetable.Rows)
                {
                    if (row.IsNewRow) continue;

                    string rowDate = row.Cells["Date"].Value?.ToString();
                    string rowTime = row.Cells["Time"].Value?.ToString();

                    if (rowDate == t.Date && rowTime == t.Time)
                    {
                        row.Cells["Id"].Value = t.Id;
                        row.Cells["Session"].Value = string.IsNullOrEmpty(t.Session) ? "-- Select --" : t.Session;
                        row.Cells["Lab"].Value = string.IsNullOrEmpty(t.Lab) ? "-- Select --" : t.Lab;
                        row.Cells["SessionSubject"].Value = string.IsNullOrEmpty(t.Subject) ? "-- Select --" : t.Subject;

                        // Make lunch rows readonly and gray
                        if (rowTime.Contains("Lunch"))
                        {
                            row.Cells["Session"].ReadOnly = true;
                            row.Cells["Lab"].ReadOnly = true;
                            row.Cells["SessionSubject"].ReadOnly = true;

                            row.Cells["Session"].Style.BackColor = Color.LightGray;
                            row.Cells["Lab"].Style.BackColor = Color.LightGray;
                            row.Cells["SessionSubject"].Style.BackColor = Color.LightGray;
                        }
                        break;
                    }
                }
            }
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            currentWeekStart = currentWeekStart.AddDays(7);
            LoadWeek(currentWeekStart);
        }

        private void btnPrevWeek_Click(object sender, EventArgs e)
        {
            currentWeekStart = currentWeekStart.AddDays(-7);
            LoadWeek(currentWeekStart);
        }

        private void time_Click(object sender, EventArgs e)
        {
            //int currentRowCount = dataGridViewTimetable.Rows.Count;
            //if (currentRowCount >= 4)
            //{
            //    MessageBox.Show("Maximum 4 time slots only allowed.");
            //    return;
            //}

            //int index = dataGridViewTimetable.Rows.Add();
            //dataGridViewTimetable.Rows[index].Cells["Date"].Value = "";
            //dataGridViewTimetable.Rows[index].Cells["Day"].Value = "";
            //dataGridViewTimetable.Rows[index].Cells["Time"].Value = "";
            //dataGridViewTimetable.Rows[index].Cells["Session"].Value = "";
            //dataGridViewTimetable.Rows[index].Cells["Lab"].Value = "";
            //dataGridViewTimetable.Rows[index].Cells["SessionSubject"].Value = "";

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            TimetableController controller = new TimetableController();

            foreach (DataGridViewRow row in dataGridViewTimetable.Rows)
            {
                if (row.IsNewRow || row.Cells["Time"].Value?.ToString().Contains("Lunch") == true) continue;

                // Save only new rows (no Id)
                if (row.Cells["Id"].Value != null) continue;

                Timetable t = new Timetable
                {
                    Date = row.Cells["Date"].Value?.ToString(),
                    Day = row.Cells["Day"].Value?.ToString(),
                    Time = row.Cells["Time"].Value?.ToString(),
                    Session = row.Cells["Session"].Value?.ToString(),
                    Lab = row.Cells["Lab"].Value?.ToString(),
                    Subject = row.Cells["SessionSubject"].Value?.ToString()
                };

                int newId = controller.AddTimetable(t);
                row.Cells["Id"].Value = newId; // Set the DB id back into the grid
            }

            MessageBox.Show("Timetable saved successfully.");
        }

        private void btnubdate_Click(object sender, EventArgs e)
        {
            TimetableController controller = new TimetableController();

            foreach (DataGridViewRow row in dataGridViewTimetable.Rows)
            {
                if (row.IsNewRow || row.Cells["Id"].Value == null)
                    continue;

                Timetable t = new Timetable
                {
                    Id = Convert.ToInt32(row.Cells["Id"].Value),
                    Date = row.Cells["Date"].Value?.ToString(),
                    Day = row.Cells["Day"].Value?.ToString(),
                    Time = row.Cells["Time"].Value?.ToString(),
                    Session = row.Cells["Session"].Value?.ToString(),
                    Lab = row.Cells["Lab"].Value?.ToString(),
                    Subject = row.Cells["SessionSubject"].Value?.ToString()
                };

                controller.UpdateTimetable(t);
            }

            MessageBox.Show("Timetable updated successfully.");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTimetable.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewTimetable.SelectedRows[0];

                if (selectedRow.Cells["Id"].Value != null)
                {
                    int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    TimetableController controller = new TimetableController();
                    controller.DeleteTimetable(id);

                    dataGridViewTimetable.Rows.Remove(selectedRow);

                    MessageBox.Show("Row deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Selected row is not saved in database yet.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
