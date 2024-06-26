﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one team
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Represents list of team members.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents team name.
        /// </summary>
        public string TeamName { get; set; }

    }
}
