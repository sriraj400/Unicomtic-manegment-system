using System;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Unicomtic_manegment_system.data
{
    internal class tablecreate
    {
        public static void CreateTables()
        {
            using (var conn = dbconnection.GetConnection())
            {
                var tables = new string[]
                {
                    // Admin Login
                    @"CREATE TABLE IF NOT EXISTS loginadmin (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserName TEXT NOT NULL,
                        Password TEXT NOT NULL
                    );",

                    // User Login
                    @"CREATE TABLE IF NOT EXISTS loginusers (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserName TEXT NOT NULL,
                        Password TEXT NOT NULL
                    );",

                    // Student
                    @"CREATE TABLE IF NOT EXISTS Student (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        utnumber INTEGER NOT NULL UNIQUE,
                        studentname TEXT NOT NULL,
                        datebirth TEXT NOT NULL,
                        nic INTEGER NOT NULL UNIQUE,
                        coursename TEXT NOT NULL
                    );",

                    // Lecture
                    @"CREATE TABLE IF NOT EXISTS lecture (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        lectureid INTEGER UNIQUE,
                        lecturename TEXT NOT NULL,
                        datebirth TEXT NOT NULL,
                        nic INTEGER NOT NULL UNIQUE,
                        coursename TEXT NOT NULL
                    );",

                    // Course
                    @"CREATE TABLE IF NOT EXISTS course (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        courseid INTEGER UNIQUE,
                        coursename TEXT NOT NULL,
                        subjectname TEXT
                    );",

                    // Staff
                    @"CREATE TABLE IF NOT EXISTS staff (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        staffid INTEGER UNIQUE,
                        staffname TEXT NOT NULL,
                        nic TEXT NOT NULL UNIQUE,
                        dateofbirth TEXT NOT NULL,
                        worktype TEXT NOT NULL
                    );",

                    // UT Marks
                    @"CREATE TABLE IF NOT EXISTS ut_marks (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        utnumber INTEGER NOT NULL,
                        exameid INTEGER NOT NULL UNIQUE,
                        examedate TEXT NOT NULL,
                        subjectname TEXT NOT NULL,
                        coursename TEXT NOT NULL,
                        marks INTEGER NOT NULL
                    );",

                    // Subject
                    @"CREATE TABLE IF NOT EXISTS subject (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        subjectid INTEGER NOT NULL UNIQUE,
                        subjectname TEXT NOT NULL 
                    );",

                    // Room
                    @"CREATE TABLE IF NOT EXISTS Room (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        roomid INTEGER NOT NULL UNIQUE,
                        roomname TEXT NOT NULL 
                    );",

                    // Users with Image
                    @"CREATE TABLE IF NOT EXISTS Users (
                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserName TEXT NOT NULL,
                        Password TEXT NOT NULL,
                        Role TEXT NOT NULL,
                        Mail TEXT,
                        Address TEXT,
                        Phone_no TEXT,
                        NIC_no TEXT,
                        UserImage BLOB
                    );",

                    // ✅ Fixed Feedback Table
                    @"CREATE TABLE IF NOT EXISTS Feedback (
                        FeedbackId INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT,
                        Rating TEXT,
                        Message TEXT,
                        SubmittedAt TEXT
                    );",
                      @"CREATE TABLE IF NOT EXISTS timetable (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        date TEXT NOT NULL,
                        day TEXT NOT NULL,
                        time TEXT NOT NULL,
                        session TEXT,
                        lab TEXT,
                        subject TEXT
                    );",
                        @"CREATE TABLE IF NOT EXISTS Attendance (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        UTNumber TEXT,
                        StudentName TEXT,
                        Date TEXT,
                        Status TEXT
                    );"

            }
            ;

                // Loop to create tables
                foreach (var sql in tables)
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
