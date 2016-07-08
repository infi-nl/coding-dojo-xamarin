using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain {

    public class CheckedAnswer {

        /// <summary>
        /// Question ID
        /// </summary>
        public int    QuestionId { get; set; }

        /// <summary>
        /// Answer key (A, B, C, D)
        /// </summary>
        public string AnswerKey  { get; set; }

        /// <summary>
        /// Whether or not given answer is correct
        /// </summary>
        public bool   IsCorrect  { get; set; }

    }

}
