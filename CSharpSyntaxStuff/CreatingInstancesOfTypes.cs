
using System.Collections;
using System.Runtime.InteropServices;

namespace CSharpSyntaxStuff;

public class CreatingInstancesOfTypes
{
    [Fact]
    public void DeterminingTypes()
    {
        var favoriteNumbers = new List<int>();
        favoriteNumbers.Add(10);
        favoriteNumbers.Add(20);
        
        var sumOfFirstTwo = favoriteNumbers[0] + favoriteNumbers[1];
        Assert.Equal(30, sumOfFirstTwo);
    }

    [Fact] 
    public void OldSchoolCollections()
    {
        var favoriteNumbers = new ArrayList(); favoriteNumbers.Add(9); favoriteNumbers.Add(42); favoriteNumbers.Add(20);

        Assert.Equal(9, favoriteNumbers[0]);

        favoriteNumbers.Add("Pizza");

        favoriteNumbers[0] = "Three";        
        var sumOfFirstTwo = ((int)favoriteNumbers[0]) + ((int)favoriteNumbers[1]);

        Assert.Equal(51, sumOfFirstTwo);
    }

    [Fact]
    public void NewSchoolCollections()
    {        // Parametric Polymorphism        
        var favoriteNumbers = new List<int>();

        favoriteNumbers.Add(9); favoriteNumbers.Add(42); favoriteNumbers.Add(20);

        var sumOfFirstTwo = favoriteNumbers[0] + favoriteNumbers[1]; Assert.Equal(51, sumOfFirstTwo);
    }


}
