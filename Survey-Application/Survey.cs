/*
 * Survey.cs
 * Author: Brandon Bednar
 * Purpose: Class representing a collection of questions to be polled (the survey)
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Survey_Application
{
    /// <summary>
    /// Class representing a collection of questions to be polled (the survey)
    /// </summary>
    public class Survey
    {
        private string title = "";
        /// <summary>
        /// The title of the survey
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private uint numberQuestions;
        /// <summary>
        /// The number of questions in the the survey
        /// </summary>
        public uint NumberQuestions
        {
            get { return numberQuestions; }
            set { numberQuestions = value; }
        }

        private uint numberPages;
        /// <summary>
        /// The number of pages used in the survey
        /// </summary>
        public uint NumberPages
        {
            get { return numberPages; }
            set { numberPages = value; }
        }

        private List<Question> Questions = new List<Question>();

        private List<Response> Respones = new List<Response>();
    }
}
