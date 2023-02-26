using System;
using System.Collections.Generic;

namespace CourseLib
{
    /// <summary>
    /// Author: Yanzhi Wang
    /// Purpose: Represents a course with a unique course code and meeting time
    /// Restrictions: None
    /// </summary>
    public class Course
    {
        public string courseCode { get; }
        public string courseTitle { get; set; }
        public string instructorName { get; set; }
        public List<DayOfWeek> daysOfWeek { get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }

        /// <summary>
        /// Creates a new Course instance with the specified course code
        /// </summary>
        /// <param name="courseCode">The unique course code for the course</param>
        public Course(string courseCode)
        {
            this.courseCode = courseCode;
            daysOfWeek = new List<DayOfWeek>();
        }

        /// <summary>
        /// Adds the specified day of the week to the list of days on which the course meets
        /// </summary>
        /// <param name="dayOfWeek">The day of the week on which the course meets</param>
        public void AddDayOfWeek(DayOfWeek dayOfWeek)
        {
            daysOfWeek.Add(dayOfWeek);
        }

        /// <summary>
        /// Removes the specified day of the week from the list of days on which the course meets
        /// </summary>
        /// <param name="dayOfWeek">The day of the week to remove</param>
        public void RemoveDayOfWeek(DayOfWeek dayOfWeek)
        {
            daysOfWeek.Remove(dayOfWeek);
        }

        /// <summary>
        /// Determines whether the course meets on the specified day of the week
        /// </summary>
        /// <param name="dayOfWeek">The day of the week to check</param>
        /// <returns>True if the course meets on the specified day of the week, false otherwise</returns>
        public bool MeetsOn(DayOfWeek dayOfWeek)
        {
            return daysOfWeek.Contains(dayOfWeek);
        }
    }

    /// <summary>
    /// Author: Yanzhi Wang
    /// Purpose: Represents a collection of courses
    /// Restrictions: None
    /// </summary>
    public class CourseCollection
    {
        private Dictionary<string, Course> courses;

        /// <summary>
        /// Creates a new CourseCollection instance
        /// </summary>
        public CourseCollection()
        {
            courses = new Dictionary<string, Course>();
        }

        /// <summary>
        /// Gets or sets the course with the specified course code
        /// </summary>
        /// <param name="courseCode">The course code of the course to get or set</param>
        /// <returns>The course with the specified course code</returns>
        public Course this[string courseCode]
        {
            get { return courses[courseCode]; }
            set { courses[courseCode] = value; }
        }

        /// <summary>
        /// Adds the specified course to the collection
        /// </summary>
        /// <param name="course">The course to add</param>
        public void Add(Course course)
        {
            courses[course.courseCode] = course;
        }

        /// <summary>
        /// Removes the course with the specified course code from the collection
        /// </summary>
        /// <param name="courseCode">The course code of the course to remove</param>
        public void Remove(string courseCode)
        {
            courses.Remove(courseCode);
        }
    }
}
