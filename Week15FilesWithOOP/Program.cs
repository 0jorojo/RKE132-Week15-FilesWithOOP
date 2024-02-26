//data from file

List<Movie> myMovies = new List<Movie>();       //empty list that can hold objects

string[] data = getDataFromFile();
//readDataFromArray(data);      

foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    //tempArray is array of all 3 row data entries, each has [index 0..2]
    //split ignores spaces
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);     //creates new entry of movie class in myMovies list
}    

foreach(Movie movie in myMovies)
{
    Console.WriteLine($"{movie.Title} was released in {movie.Year}.");
}

static string[] getDataFromFile()
{
    string filePath = @"D:\OneDrive - Tallinna Tehnikakõrgkool\Programmeerimine\movies.txt";
    return File.ReadAllLines(filePath);
}

static void readDataFromArray(string[] someArray)   //data in rows is split by semicolons ;
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}
class Movie
{
    string title;    //fields, what class needs
    string year;

    public string Title     //getter
    { get { return title; } }

    public string Year      //getter
    { get { return year; } }

    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}