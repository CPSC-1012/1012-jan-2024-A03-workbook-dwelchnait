// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ins and Outs of file processing\n\n");

string[] studentNames = new string[25];
double[] studentMark = new double[25];
int logicalSize = 0;

logicalSize = ReadNamesandMarks(studentNames, studentMark);

DisplayStudentAndMarks(studentNames, studentMark, logicalSize);

WriteNamesandMarks(studentNames, studentMark, logicalSize);

static void DisplayStudentAndMarks(string[] names,
                                    double[] marks,
                                    int logicalSize)
{
    Console.WriteLine("The following is your students and marks\n\n");
    Console.WriteLine("{0,-25} {1,6:f1}", "Student", "Grade");
    Console.WriteLine("{0,-25} {1,6:f1}", "=========================", "======");

    for (int i = 0; i < logicalSize; i++)
    {
        Console.WriteLine("{0,-25} {1,6:f1}",names[i],marks[i]);
    }

}

static int ReadNamesandMarks(string[] names,
                              double[] marks)
{
    //the skeleton of the method is often referred to as
    //  a method stub.

    //Class to read a file can be
    //StreamReader
    //  is useful if you have a very large file and your intenion
    //      is may not to read then entire file
    //File
    //  is useful when you have a file you intend to completly read
    //  is not extremely large
    //  will do some of your "homekeeping" that you must manually do
    //      when using Stream classes

    // need to remember the number of records read
    // the array will only hold 25 records
    int logicalSize = 0; //number of records read

  
    //Need to know
    //a) where is the file located
    //b) what is the file name

    //by default and file accessed by your Stream classes assumes the
    //   phyiscal file will be in the same folder as your .exe file

    //you can use relative addressing in your file path name to redirect
    //  the system to another location to access the phyiscal file

    //setup the StreamReader instance
    string fileName = "../../../CourseGradesX.csv";
    StreamReader reader = null;
    string inputLine = "";

    //use the File class to test if a file exists BEFORE trying to use
    if (File.Exists(fileName))
    {
        try
        {
            //setup your instance of the class StreamReader
            reader = new StreamReader(fileName);
            //read the file
            //you will know when to stop via the property EndOfStream is equal to true
            while (!reader.EndOfStream)
            {
                //read a line off the file
                inputLine = reader.ReadLine();

                //next, we need to separate the values on the line into
                //  their approperiate arrays

                //so do this, we will use a string method call Split('deliminator')
                //for a csv (comma separated values) file the deliminator is a comma ,
                string[] lineValues = inputLine.Split(',');
                names[logicalSize]= lineValues[0];
                marks[logicalSize]= double.Parse(lineValues[1]);
                logicalSize++;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"System Error: {ex.Message}");
        }
        finally
        {
            //this is an optionally piece of code that can be used on your try/catch
            //normally
            //  you will execute all of the try successfully, exit the try/catch
            //or
            //  an error will be generated and you will process the catch, exit the try/catch

            //the finally will be execute whether you exited the try/catch successful or having
            //      an error

            //in this code, we will manually close the filename that is being read
            if (reader != null)
            {
                reader.Close();
            }
        }
    }//eof of File.Exist
        return logicalSize;
}

static void WriteNamesandMarks(string[] names,
                              double[] marks,
                              int logicalSize)
{

    //setup the StreamWriter instance
    string fileName = "../../../CourseGrades.txt";
    StreamWriter writer = null;
    string outputLine = "";
    try
    {
        //setup your instance of the class StreamWriter
        //if your file does not exist, it will be created
        //dependent on write options
        // a) overwrite all existing lines (false)
        // b) append to the existing lines (true)
        writer = new StreamWriter(fileName,true);
        //write to the file
        //your program will control when to stop writing
        for(int i = 0; i < logicalSize; i++)
        {
            if (i % 2 == 0)
            {
                //build the line to write
                outputLine = $"{names[i]},{marks[i]}";
                //write the line to your file

                writer.WriteLine(outputLine);
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"System Error: {ex.Message}");
    }
    finally
    {
       
        if (writer != null)
        {
            writer.Close();
        }
    }
   
}