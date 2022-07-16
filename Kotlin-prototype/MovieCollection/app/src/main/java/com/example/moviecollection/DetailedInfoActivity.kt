package com.example.moviecollection

import android.content.Intent
import android.os.Bundle
import android.view.Menu
import android.view.MenuInflater
import android.view.MenuItem
import android.widget.Button
import android.widget.TextView
import androidx.appcompat.app.ActionBar
import androidx.appcompat.app.AppCompatActivity
import com.example.moviecollection.model.Movie

class DetailedInfoActivity : AppCompatActivity() {

    companion object {
        var MOVIE = Movie("title", 0, "director", "format", false)
    }
    var INDEX: Int = 0

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_detail)

        MOVIE = intent?.extras?.getSerializable("movie") as Movie
        INDEX = intent?.extras?.getInt("index") as Int

        setSupportActionBar(findViewById(R.id.detail_toolbar))
        val actionBar: ActionBar = getSupportActionBar() as ActionBar
        actionBar.setDisplayHomeAsUpEnabled(true)

        // Retrieve a binding object that allows you to refer to views by id name
        // Names are converted from snake case to camel case.
        // For example, a View with the id word_one is referenced as binding.wordOne
//        val binding = ActivityDetailBinding.inflate(layoutInflater)
//        setContentView(binding.root)

        val textViewTitle = findViewById<TextView>(R.id.textViewTitle)
        val textViewYear = findViewById<TextView>(R.id.textViewYear)
        val textViewDirector = findViewById<TextView>(R.id.textViewDirector)
        val textViewFormat = findViewById<TextView>(R.id.textViewFormat)
        val textViewFavourite = findViewById<TextView>(R.id.textViewFavourite)
        textViewTitle.text = MOVIE.title
        textViewYear.text = "Released: ${MOVIE.year.toString()}"
        textViewDirector.text = "Director: ${MOVIE.director}"
        textViewFormat.text = "Format: ${MOVIE.format}"
        textViewFavourite.text = "Favourite: ${MOVIE.favourite.toString()}"

        this.title = "Detailed info"
    }

    // Shows overflow menu in toolbar
    override fun onCreateOptionsMenu(menu: Menu): Boolean {
        val inflater: MenuInflater = menuInflater
        inflater.inflate(R.menu.toolbar_detail, menu)
        return true
    }

    // Handlers for toolbar menu options
    override fun onOptionsItemSelected(item: MenuItem) = when (item.itemId) {
        R.id.action_edit -> {
            val intent = Intent(this, EditMovieActivity::class.java)
            intent.putExtra("movie", MOVIE)
            intent.putExtra("index", INDEX)
            startActivity(intent)

//            val intent = Intent(this, EditMovieActivity::class.java)
//            startActivity(intent)
//            val intent = Intent(this, MainActivity::class.java)
//            startActivity(intent)
            true
        }
        R.id.action_delete -> {
            deleteMovie(INDEX)
            val intent = Intent(this, MainActivity::class.java)
            startActivity(intent)
            true
        }
        else -> {
            super.onOptionsItemSelected(item)
        }
    }

    private fun addMovie(index: Int) {
        val saveManager = SharedPreferenceManager(this)
        val list: MutableList<Movie?> = saveManager.loadMovieList()
        list.removeAt(index)
        saveManager.saveMovieList(list)
    }

    private fun deleteMovie(index: Int) {
        val saveManager = SharedPreferenceManager(this)
        val list: MutableList<Movie?> = saveManager.loadMovieList()
        list.removeAt(index)
        saveManager.saveMovieList(list)
    }
}