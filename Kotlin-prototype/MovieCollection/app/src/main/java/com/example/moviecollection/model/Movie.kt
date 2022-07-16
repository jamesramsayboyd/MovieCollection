package com.example.moviecollection.model

import com.google.gson.Gson
import java.io.Serializable

// class representing a movie on DVD
data class Movie (
    val title: String,
    val year: Int,
    val director: String,
    val format: String,
    val favourite: Boolean
        ) : Serializable, Comparable<Movie> {
    override fun compareTo(other: Movie): Int {
        return if (other.title > this.title) {
            1
        } else if (other.title < this.title) {
            -1
        } else
            0
    }
}