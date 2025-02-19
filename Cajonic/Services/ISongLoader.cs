﻿using Cajonic.Model;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Cajonic.Services
{
    public interface ISongLoader
    {
        ImmutableList<Song> LoadSongs(string[] path, ICollection<Artist> artists, ICollection<Song> allSongs);
    }
}
