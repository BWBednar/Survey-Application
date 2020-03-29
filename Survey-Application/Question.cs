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
        //private variables that will be set to their actual values in the constructor
        private string questionText = "";
        private uint questionNumber;
        private uint questionPage;
        private QuestionType type = QuestionType.Scale;

        /// <summary>
        /// Constructor for the Question instance, allows the private variables to only be set once
        /// </summary>
        /// <param name="qt">The text for asking the question</param>
        /// <param name="qn">The number of the question in the survey</param>
        /// <param name="qp">The page of the survey that the question is in</param>
        /// <param name="t">The type of question that question is</param>
        public Question(string qt, uint qn, uint qp, QuestionType t)
        {
            questionText = qt;
            questionNumber = qn;
            questionPage = qp;
            type = t;
        }

        /// <summary>
        /// The text that will be used to ask the survey question
        /// </summary>
        public string QuestionText
        {
            get { return questionText; }
        }

        /// <summary>
        /// The number of the question in the survey as a whole
        /// </summary>
        public uint QuestionNumber
        {
            get { return questionNumber; }
        }

        
        /// <summary>
        /// The page of the survey that the question is located in
        /// </summary>
        public uint QuestionPage
        {
            get { return questionPage; }
        }

        /// <summary>
        /// The type of question that is associated with this question
        /// Will be a scale, single choice, multiple choice, or open-ended question
        /// </summary>
        public QuestionType Type
        {
            get { return type; }
        }
    }
}
