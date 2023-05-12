namespace SignalAggregationTask
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            /*
             * I've left this note here for some additional guidance
             * 
             * This example should give you a signal box that switches between Red and Green showing aggregation
             * You need to modify this signal box to add a yellow light in between the red and green in the signal box (or whatever you call your traffic light) class.
             * You will then need to modify the changeLights to have the states of a traffic light (0 = Red, 1 = Red + Yellow, 2 = Green, 3 = Yellow)
             * You will also need to modify the displayLights method to include the yellow light.
             * At this point check that you have a working traffic light.
             * 
             * Create a second traffic light, this can all be done in Form1.
             * Ensure you make the traffic light change its state on the timer tick.
             * Ensure the traffic light is drawn in the paint event.
             */
        }
    }
}