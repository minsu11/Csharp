using System.Text;
/*
이 C# 콘솔 애플리케이션은 다음을 위해 설계되었습니다.
- 배열을 사용하여 학생 이름과 과제 점수를 저장합니다.
- 'foreach' 문을 사용하여 외부 프로그램 루프로 학생 이름을 반복합니다.
- 외부 루프 내에서 `if` 문을 사용하여 현재 학생 이름을 식별하고 해당 학생의 과제 점수에 액세스합니다.
- 외부 루프 내에서 `foreach` 문을 사용하여 할당 점수 배열을 반복하고 값을 합산합니다.
- 외부 루프 내의 알고리즘을 사용하여 각 학생의 평균 시험 점수를 계산합니다.
- 외부 루프 내에서 `if-elseif-else` 구성을 사용하여 평균 시험 점수를 평가하고 문자 등급을 자동으로 할당합니다.
- 학생의 최종 점수 및 문자 등급을 계산할 때 다음과 같이 추가 학점을 통합합니다.
    - 학생 점수 배열의 요소 수를 기반으로 추가 학점 할당을 감지합니다.
    - 시험 점수 합계에 추가 학점을 더하기 전에 추가 학점 할당 값을 10으로 나눕니다.
- 학생 성적을 보고하려면 다음 보고서 형식을 사용하십시오.

    Student         Grade

    Sophia:         92.2    A-
    Andrew:         89.6    B+
    Emma:           85.6    B
    Logan:          91.2    A-
*/

int exam_subject = 5;

Dictionary<string, int[]> studentsDictionary = new Dictionary<string, int[]>(){
    {"a",new int[] { 100, 20, 90,80,50}},
    {"b",new int[] { 30, 40, 10, 100,20 }},
    {"c", new int[] { 45, 66, 84, 10, 50 }},
    {"d",new int[] { 30, 54, 20, 70, 50 }}
};



Console.WriteLine("Student\t\tGrade\t\tLetter Grade");
StringBuilder sb = new StringBuilder("");


foreach (KeyValuePair<string, int[]> student in studentsDictionary) {
    try
    {
        

        int scoreAvg = student.Value.Sum() / exam_subject;
        sb.Append(student.Key + "\t\t" + scoreAvg + "\t\t");
        if (scoreAvg >= 90)
        {
            sb.Append("A\n");
        }
        else if (scoreAvg >= 80)
        {
            sb.Append("B\n");
        }
        else if (scoreAvg >= 70)
        {
            sb.Append("C\n");
        }
        else if (scoreAvg >= 60)
        {
            sb.Append("D\n");
        }
        else if (scoreAvg <60)
        {
            sb.Append("F\n");
        }
        else
        {
            throw new Exception("해당 점수가 없습니다.");
        }
    }catch(Exception e ){
        Console.WriteLine("" + e.Message);
    }
}
Console.WriteLine(sb.ToString());
Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();
