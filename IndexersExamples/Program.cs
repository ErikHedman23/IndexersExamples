using IndexersExamples;

MusicGenres genres = new MusicGenres();

int count = 0;
while (count < 5)
{
    genres[count] = Console.ReadLine();
    count++;
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Following: " + genres[i]);
}
