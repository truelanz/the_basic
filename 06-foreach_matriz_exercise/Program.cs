
int examAssignments = 5;

string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan", "Tomas", "Mathew" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] tomasScores = new int[] { 90, 85, 87, 79, 100, 96 };
int[] mathewScores = new int[] { 90, 99, 77, 88, 78, 86 };

int[] studentScores = new int[10];
string currentLetterGrade = "";


foreach (string name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Tomas")
        studentScores = tomasScores;

    else if (currentStudent == "Mathew")
        studentScores = mathewScores;

    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int gradedAssignments = 0;

    /* 
    
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;
        else
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentLetterGrade = "A+";
    else if (currentStudentGrade >= 96)
        currentLetterGrade = "A";
    else if (currentStudentGrade >= 92)
        currentLetterGrade = "A-";
    else if (currentStudentGrade >= 89)
        currentLetterGrade = "B+";
    else if (currentStudentGrade >= 86)
        currentLetterGrade = "B";
    else if (currentStudentGrade >= 82)
        currentLetterGrade = "B-";
    else if (currentStudentGrade >= 79)
        currentLetterGrade = "C+";
    else if (currentStudentGrade >= 76)
        currentLetterGrade = "C";
    else if (currentStudentGrade >= 72)
        currentLetterGrade = "C-";
    else if (currentStudentGrade >= 69)
        currentLetterGrade = "D+";
    else if (currentStudentGrade >= 66)
        currentLetterGrade = "D";
    else if (currentStudentGrade >= 62)
        currentLetterGrade = "D-";
    else if (currentStudentGrade <= 59)
        currentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t {currentStudentGrade}\t {currentLetterGrade}");
}

Console.ReadLine();