namespace Invitation_App.Models
{
    public class Repository
    {
        private static List<Answer> answers = new List<Answer>();
        public static IEnumerable<Answer> Answers => answers;

        public static void AddAnswer(Answer answer)
        {
            answers.Add(answer); 
        }
}

}
