/*
 * Response.cs
 * Author:Brandon Bednar
 * Purpose: Class representing a single response to a ballot
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Survey_Application
{
    /// <summary>
    /// Class representing a single response to a ballot
    /// </summary>
    public class Response
    {
        private string name = "";
        /// <summary>
        /// The name of the person filling out the ballot
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private uint age;
        /// <summary>
        /// The age of the person filling out the ballot
        /// </summary>
        public uint Age
        {
            get { return age; }
            set { age = value; }
        }

        private string email = "";
        /// <summary>
        /// The email of the person filling out the ballot
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// List of the types of questions the person is responding to
        /// </summary>
        private List<QuestionType> ResponseType = new List<QuestionType>();

        /// <summary>
        /// List of the person's responses to the questions
        /// </summary>
        private List<Object> Answers = new List<Object>();
    }
}
