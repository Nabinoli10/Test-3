type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

type Director = {
    Name: string
    Movies: int
}

type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}

// Create movie instances according to the table provided
let movies = [
    { Name = "CODA"; RunLength = 111; Genre = Drama; Director = { Name = "Sian Heder"; Movies = 9 }; IMDBRating = 8.1 }
    { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = { Name = "Kenneth Branagh"; Movies = 23 }; IMDBRating = 7.3 }
    { Name = "Don't Look Up"; RunLength = 138; Genre = Comedy; Director = { Name = "Adam McKay"; Movies = 27 }; IMDBRating = 7.2 }
    { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = { Name = "Ryusuke Hamaguchi"; Movies = 16 }; IMDBRating = 7.6 }
    { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; Movies = 24 }; IMDBRating = 8.1 }
    { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; Movies = 15 }; IMDBRating = 7.5 }
    { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = { Name = "Paul Thomas Anderson"; Movies = 49 }; IMDBRating = 7.4 }
    { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = { Name = "Guillermo Del Toro"; Movies = 22 }; IMDBRating = 7.1 }
]

// Identify probable Oscar winners
let probableOscarWinners = movies |> List.filter (fun movie -> movie.IMDBRating > 7.4)

// Convert movie run length to hours and minutes format
let convertToHoursAndMinutes runLength =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

let runLengthsInHours = movies |> List.map (fun movie -> convertToHoursAndMinutes movie.RunLength)

// Output the probable Oscar winners
printfn "Probable Oscar Winners:"
probableOscarWinners |> List.iter (fun movie -> 
    printfn "Name: %s, IMDB Rating: %.1f" movie.Name movie.IMDBRating
)

// Output the run lengths in hours and minutes
printfn "\nRun Lengths in Hours and Minutes:"
runLengthsInHours |> List.iter (fun length -> printfn "%s" length)