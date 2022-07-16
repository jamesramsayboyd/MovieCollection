package com.example.moviecollection

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.Menu
import android.view.MenuInflater
import android.view.MenuItem
import androidx.appcompat.app.ActionBar
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.moviecollection.adapter.MovieTitleAdapter
import com.example.moviecollection.data.Datasource
import com.example.moviecollection.model.Movie
import com.example.moviecollection.SharedPreferenceManager

class MainActivity : AppCompatActivity() {
    private lateinit var recyclerView: RecyclerView
    private lateinit var movieList: MutableList<Movie?>
    final val saveManager = SharedPreferenceManager(this)

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        // setting app toolbar
        setSupportActionBar(findViewById(R.id.main_toolbar))
        val actionBar: ActionBar = getSupportActionBar() as ActionBar
        actionBar.setDisplayHomeAsUpEnabled(false)

        // Initialise data
//        var movieList = Datasource().loadMovies() // hardcoded list for testing
        val saveManager = SharedPreferenceManager(this)
        movieList = saveManager.loadMovieList()
//
        // Creating a RecyclerView variable
        recyclerView = findViewById(R.id.recycler_view)
        // Assigning the custom MovieTitleAdapter to the RecyclerView
        recyclerView.adapter = MovieTitleAdapter(this, movieList)
        recyclerView.layoutManager = LinearLayoutManager(this)
        // Fixing size of RecyclerView to improve performance
        recyclerView.setHasFixedSize(true)

//        saveManager.saveMovieList(movieList)
    }

    // Shows overflow menu in toolbar
    override fun onCreateOptionsMenu(menu: Menu): Boolean {
        val inflater: MenuInflater = menuInflater
        inflater.inflate(R.menu.toolbar_main, menu)
        return true
    }

    // Handlers for toolbar menu options
    override fun onOptionsItemSelected(item: MenuItem) = when (item.itemId) {
        R.id.action_add -> {
            val intent = Intent(this, AddMovieActivity::class.java)
            startActivity(intent)
            true
        }
        R.id.action_sort_title -> {
            this.title="Sorted by title, A to Z"
            movieList.sortBy {it?.title}
            recyclerView.adapter?.notifyDataSetChanged()
            true
        }
        R.id.action_sort_year -> {
            this.title="Sorted by release, old to new"
            movieList.sortBy {it?.year}
            recyclerView.adapter?.notifyDataSetChanged()
            true
        }
        R.id.action_sort_director -> {
            this.title="Sorted by Director"
            movieList.sortBy {it?.director}
            recyclerView.adapter?.notifyDataSetChanged()
            true
        }
        else -> {
            super.onOptionsItemSelected(item)
        }
    }

//    override fun onDestroy() {
//        super.onDestroy()
////        saveManager.saveMovieList(movieList)
//    }
}