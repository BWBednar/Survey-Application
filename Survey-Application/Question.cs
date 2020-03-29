/*
 * Question.cs
 * Author: Brandon Bednar
 * Purpose: Class representing a single question of the survey
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey_Application
{
    /// <summary>
    /// Class representing a single question of the survey
    /// </summary>
    public class Question
    {
        private string questionText = "";
        /// <summary>
        /// The text that will be used to ask the survey question
        /// </summary>
        public string QuestionText
        {
            get { return questionText; }
            protected set { questionText = value; }
        }

        private uint questionNumber;
        /// <summary>
        /// The number of the question in the survey as a whole
        /// </summary>
        public uint QuestionNumber
        {
            get { return questionNumber; }
            protected set { questionNumber = value; }
        }

        private uint questionPage;
        /// <summary>
        /// The page of the survey that the question is located in
        /// </summary>
        public uint QuestionPage
        {
            get { return questionPage; }
            protected set { questionPage = value; }
        }

        private QuestionType type = QuestionType.Scale;
        /// <summary>
        /// The type of question that is associated with this question
        /// Will be a scale, single choice, multiple choice, or open-ended question
        /// </summary>
        public QuestionType Type
        {
            get { return type; }
            protected set { type = value; }
        }
    }
}
