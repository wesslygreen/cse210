using System;

class Program
{
    static void Main(string[] args)
    {
        // lecture
        Lecture lectureEvent = new Lecture();
        lectureEvent.setTitle("Programming 101");
        lectureEvent.setDescription("Learn how to program with C#.");
        lectureEvent.setSpeaker("Elon Musk");
        lectureEvent.setDate("01/12/23");
        lectureEvent.setTime("12 pm");
        lectureEvent.setAddress("23 West Street, Rexburg, Idaho 84340");
        lectureEvent.setCapacity(25);
        lectureEvent.getStandardDetails();
        lectureEvent.getLectureDetails();
        lectureEvent.getShortDescription();

        // reception
        Reception receptionEvent = new Reception();
        receptionEvent.setTitle("Balon de Oro Reception");
        receptionEvent.setDescription("Reception for the Balon de Oro ceremony.");
        receptionEvent.setDate("04/23/23");
        receptionEvent.setTime("8 pm");
        receptionEvent.setAddress("454 Longview Lane, Boise, Idaho 84341");
        receptionEvent.setRegistered(1000);
        receptionEvent.getStandardDetails();
        receptionEvent.getReceptionDetails();
        receptionEvent.getShortDescription();

        // outdoor gathering
        OutdoorGathering outdoorEvent = new OutdoorGathering();
        outdoorEvent.setTitle("Outdoor Soccer");
        outdoorEvent.setDescription("BYUI intramural soccer final.");
        outdoorEvent.setDate("05/05/2023");
        outdoorEvent.setAddress("34 East Street, Rexburg, Idaho 83401");
        outdoorEvent.setTime("7 pm");
        outdoorEvent.setForecast("Cloudy");
        outdoorEvent.getStandardDetails();
        outdoorEvent.getOutdoorDetails();
        outdoorEvent.getShortDescription();
    }
}