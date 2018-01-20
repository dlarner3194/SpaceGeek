using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace SpaceGeek
{
  public class Function
  {
    public List<FactResource> GetResources()
    {
      List<FactResource> resources = new List<FactResource>();
      FactResource enUSResource = new FactResource("en-US");
      enUSResource.SkillName = "American Space Facts";
      enUSResource.GetFactMessage = "Here's your fact: ";
      enUSResource.HelpMessage = "You can say tell me a space fact, or, you can say exit... What can I help you with?";
      enUSResource.HelpReprompt = "What can I help you with?";
      enUSResource.StopMessage = "Goodbye!";
      enUSResource.Facts.Add("A year on Mercury is just 88 days long.");
      enUSResource.Facts.Add("Despite being farther from the Sun, Venus experiences higher temperatures than Mercury.");
      enUSResource.Facts.Add("Venus rotates counter-clockwise, possibly because of a collision in the past with an asteroid.");
      enUSResource.Facts.Add("On Mars, the Sun appears about half the size as it does on Earth.");
      enUSResource.Facts.Add("Earth is the only planet not named after a god.");
      enUSResource.Facts.Add("Jupiter has the shortest day of all the planets.");
      enUSResource.Facts.Add("The Milky Way galaxy will collide with the Andromeda Galaxy in about 5 billion years.");
      enUSResource.Facts.Add("The Sun contains 99.86% of the mass in the Solar System.");
      enUSResource.Facts.Add("The Sun is an almost perfect sphere.");
      enUSResource.Facts.Add("A total solar eclipse can happen once every 1 to 2 years. This makes them a rare event.");
      enUSResource.Facts.Add("Saturn radiates two and a half times more energy into space than it receives from the sun.");
      enUSResource.Facts.Add("The temperature inside the Sun can reach 15 million degrees Celsius.");
      enUSResource.Facts.Add("The Moon is moving approximately 3.8 cm away from our planet every year.");

      resources.Add(enUSResource);
      return resources;
    }


    public string FunctionHandler(string input, ILambdaContext context)
    {
      return input?.ToUpper();
    }
  }

  public class FactResource
  {
    public FactResource(string language)
    {
      this.Language = language;
      this.Facts = new List();
    }

    public string Language { get; set; }
    public string SkillName { get; set; }
    public List<string> Facts { get; set; }
    public string GetFactMessage { get; set; }
    public string HelpMessage { get; set; }
    public string HelpReprompt { get; set; }
    public string StopMessage { get; set; }
  }

}
