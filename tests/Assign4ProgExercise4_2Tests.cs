using Xunit;
using System.IO;
using System;
using System.Text;

public class Assign4ProgExercise4_2Tests
{

    [Fact]
    public void TestCase1()
    {
        //Sets the Out property to target the TextWriter object. Note that the System.IO.StringWriter is 
        //derived from TextWriter. The TextWriter class is an abstract class. Therefore, you do not 
        //instantiate it in your code.
        //The StreamWriter class derives from TextWriter and provides implementations of the members for 
        //writing to a stream. 
        var output = new StringWriter();
        Console.SetOut(output);

        //Sets the In property to the specified TextReader object. System.IO.StringReader is derived
        //from TextReader. The TextReader class is an abstract class. Therefore, you do not instantiate 
        //it in your code.
        //The StreamReader class derives from TextReader and provides implementations of the 
        //members for reading from a stream.
        //Use case 1
        var textInput = "Once more unto the breach, dear friends, once more";

        var input = new StringReader(textInput);
        Console.SetIn(input);

        Twitter.Main();

        //use a string writer to format the expected outcome
        var expectedOutcome = new StringBuilder();
        expectedOutcome.AppendLine("Enter your short message >>");
        expectedOutcome.AppendLine("The message is okay.");

        //  Write("Enter your short message >> ");
        // message = ReadLine();
        // if(message.Length > MAX)
        //     WriteLine("The message is too long");
        // else
        //     WriteLine("The message is okay");

        Assert.Equal(expectedOutcome.ToString(), output.ToString());

        //clean up
        output.Dispose();
        input.Dispose();
    }

    [Fact]
    public void TestCase2()
    {
        //Sets the Out property to target the TextWriter object. Note that the System.IO.StringWriter is 
        //derived from TextWriter. The TextWriter class is an abstract class. Therefore, you do not 
        //instantiate it in your code.
        //The StreamWriter class derives from TextWriter and provides implementations of the members for 
        //writing to a stream. 
        var output = new StringWriter();
        Console.SetOut(output);

        //Sets the In property to the specified TextReader object. System.IO.StringReader is derived
        //from TextReader. The TextReader class is an abstract class. Therefore, you do not instantiate 
        //it in your code.
        //The StreamReader class derives from TextReader and provides implementations of the 
        //members for reading from a stream.
        //Use case 1
        var textInput = "Once more unto the breach, dear friends, once more; Or close the wall up with our English dead. In peace there's nothing so becomes a man As modest stillness and humility: But when the blast of war blows in our ears, Then imitate the action of the tiger;";

        var input = new StringReader(textInput);
        Console.SetIn(input);

        Twitter.Main();

        //use a string writer to format the expected outcome
        var expectedOutcome = new StringBuilder();
        expectedOutcome.AppendLine("Enter your short message >>");
        expectedOutcome.AppendLine("The message is too long.");

        //  Write("Enter your short message >> ");
        // message = ReadLine();
        // if(message.Length > MAX)
        //     WriteLine("The message is too long");
        // else
        //     WriteLine("The message is okay");

        Assert.Equal(expectedOutcome.ToString(), output.ToString());

        //clean up
        output.Dispose();
        input.Dispose();
    }
}
