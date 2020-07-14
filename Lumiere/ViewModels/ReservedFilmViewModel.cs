﻿using System;
using System.Collections.Generic;

namespace Lumiere.ViewModels
{
    public class ReservedFilmViewModel
    {
        public Guid SeanceId { get; set; }
        public string FilmName { get; set; }
        public string FilmPosterUrl { get; set; }
        public TimeSpan FilmDuration { get; set; }
        public DateTime SeanceDate { get; set; }
        public DateTime SeanceTime { get; set; }
        public int RoomNumber { get; set; }
        public Dictionary<int, int> RowSeatNumbers { get; set; }
    }
}
