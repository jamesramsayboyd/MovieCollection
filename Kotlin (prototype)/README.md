Initial prototype functional as Kotlin Android app.
- Main activity uses RecyclerView with adapter to display MutableList of custom Movie class
- Uses Intents to navigate between Main, Detailed Info, Add Movie and Edit Movie activities
- Uses a Toolbar with overflow menu for navigation options
- Uses Gson to convert list to Json string and save in SharedPreferences

- No error trapping
- Uses inefficient method of saving List data and recreating list in each activity to update/add/edit List objects. I need to learn how to maintain a single list for the whole app and only save/load when the app is closed/opened

This took a lot longer than I expected it to! Android development is a pretty steep learning curve coming from a .NET background.