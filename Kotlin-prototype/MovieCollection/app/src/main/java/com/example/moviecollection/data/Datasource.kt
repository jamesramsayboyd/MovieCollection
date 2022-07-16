package com.example.moviecollection.data

import com.example.moviecollection.R
import com.example.moviecollection.model.Movie

class Datasource {
    // A list of default data for testing purposes
    fun loadMovies(): MutableList<Movie?> {

        return mutableListOf(
            Movie("Blow Out", 1981, "Brian De Palma", "Blu Ray", true),
            Movie("Punch-Drunk Love", 2002, "P.T. Anderson", "DVD", true),
            Movie("Vertigo", 1958, "Alfred Hitchcock", "4K UHD", false),
            Movie("Mad Max Fury Road", 2015, "George Miller", "4K UHD", false),
            Movie("Thief", 1981, "Michael Mann", "Blu Ray", true)
        )
    }
}