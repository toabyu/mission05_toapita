$("#button").click(function () {
    // when the button gets clicked go through all the textboxes and convert the score to float
    let assignmentGrade = parseFloat($("#assignments").val())
    let groupProjectGrade = parseFloat($("#groupproject").val())
    let quizzesGrade = parseFloat($("#quizzes").val())
    let midtermGrade = parseFloat($("#midtermexam").val())
    let finalExamGrade = parseFloat($("#finalexam").val())
    let intexGrade = parseFloat($("#intex").val())

    // calculate the final grade
    let finalGrade = (assignmentGrade * .50) + (groupProjectGrade * .1) + (quizzesGrade * .1)
        + (midtermGrade * .1) + (finalExamGrade * .1) + (intexGrade * .1)

    // calculate and output letter grade and percent
    $("#result").html("Your Final Score is (" + finalGrade + ")% " + calcLetterGrade(finalGrade))

})

function calcLetterGrade(finalGrade) {

    //convert to decimal
    finalGrade = finalGrade / 100;

    // calculate the letter grade based on the scale in learningsuite
    if (finalGrade >= .94) {
        letterGrade = "A";
    } else if (finalGrade >= .90) {
        letterGrade = "A-";
    } else if (finalGrade >= .87) {
        letterGrade = "B+";
    } else if (finalGrade >= .84) {
        letterGrade = "B";
    } else if (finalGrade >= .80) {
        letterGrade = "B-";
    } else if (finalGrade >= .77) {
        letterGrade = "C+";
    } else if (finalGrade >= .74) {
        letterGrade = "C";
    } else if (finalGrade >= .70) {
        letterGrade = "C-";
    } else if (finalGrade >= .67) {
        letterGrade = "D+";
    } else if (finalGrade >= .64) {
        letterGrade = "D";
    } else if (finalGrade >= .60) {
        letterGrade = "D-";
    } else {
        letterGrade = "E";
    }

    //return the last grade
    return letterGrade;

}