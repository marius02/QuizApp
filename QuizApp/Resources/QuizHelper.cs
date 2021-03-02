namespace QuizApp.Resources
{
    public class QuizHelper
    {
        public string GetTopicDescription(string topic)
        {
            var topicDescription = topic switch
            {
                "History" => "History description",
                "Geography" => "Geography description",
                "Space" => "Space description",
                "Business" => "Business description",
                "Engineering" => "Engineering description",
                "Programming" => "Programming description",
                _ => "General Description"
            };

            return topicDescription;
        }
    }
}