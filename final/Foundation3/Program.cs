using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("143 N 759 E", "Yellow Knife", "Idaho", 83550);
        Address address2 = new Address("83 Main St", "Clayton", "Idaho", 82182);
        Address address3 = new Address("20 S 170 W", "Sun Valley", "Idaho", 88905);

        OutdoorGathering outdoorGathering = new OutdoorGathering("Harmonica Festival", "The Annual Yellow Knife Harmonica festival","14 August 2024", "2-8 PM", address1, "Mostly sunny with scattered clouds");
        Reception reception = new Reception("John and Nancy's wedding", "Come celebrate John and Nancy, the only two unmarried people left in Clayton", "5 June 1994", "6-8 PM", address2, "wecare@thiscompany.org");
        Lecture lecture = new Lecture("Ski Lifts Throughout History", "From the dawn of the ski lift, skiing has been changed forever. Come learn about how it all started and the future of ski lifts","3 December 2024","10 AM",address3, 26);

        outdoorGathering.GetStandardDetails();
        lecture.GetFullDetails();
        reception.GetShortDescription();
    }
}