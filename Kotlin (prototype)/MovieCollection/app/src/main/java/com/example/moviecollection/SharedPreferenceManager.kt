package com.example.moviecollection

import android.content.Context
import android.content.SharedPreferences
import com.example.moviecollection.model.Movie
import com.google.gson.Gson
import com.google.gson.GsonBuilder
import com.google.gson.reflect.TypeToken

/**
 * Class that handles saving and loading list of Movie objects using Shared Preferences
 */
class SharedPreferenceManager (private val context: Context) {
    private val PREFS_NAME = "com.example.moviecollection.PREFERENCES"
    private val sharedPref: SharedPreferences =
        context.getSharedPreferences(PREFS_NAME, Context.MODE_PRIVATE)
    private val gson: Gson = GsonBuilder().create()

    // Converts a single Movie object to Json string and writes to Shared Preferences
    fun saveSingleMovie(movieToSave: Movie?) {
        with(sharedPref) {
            edit().clear().apply()
            edit().putString("movie", gson.toJson(movieToSave)).apply()
        }
    }

    // Retrieves a single Movie object from a Json string in Shared Preferences
    fun loadSingleMovie(): Movie? {
        val data = sharedPref.getString("movie", null) ?: return null
        return gson.fromJson(data, Movie::class.java)
    }

    // Converts entire MutableList to Json string and saves in Shared Preferences
    fun saveMovieList(list: MutableList<Movie?>) {
        with(sharedPref) {
            edit().clear().apply() // Clears sharedpref.xml
            edit().putString("movieList", gson.toJson(list)).apply() // Writes entire list as Json string
        }
    }

    // Retrieves entire list of Movie objects as Json string, converts back to MutableList
    fun loadMovieList(): MutableList<Movie?> {
        val data = sharedPref.getString("movieList", null) // Retrieves string containing entire list
        val itemType = object : TypeToken<MutableList<Movie>>() {}.type // Establishes MutableList as desired Type
        return gson.fromJson(data, itemType) // Returns MutableList of all saved Movie objects
    }
}