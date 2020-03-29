/*
 * QuestionType.cs
 * Author: Brandon Bednar
 * Purpose: The options for the types of questions that can be in the survey
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Survey_Application
{
    /// <summary>
    /// The options for the types of questions that can be in the survey
    /// </summary>
    public enum QuestionType
    {
        Scale,
        OneChoice,
        MultipleChoice,
        OpenEnded
    }
}
