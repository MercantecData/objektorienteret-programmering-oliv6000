using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultithreadingGuessNumber
{
    public class GuessTheNumber
    {
        public delegate void StartTask();
        public delegate void EndTask();
        private static CancellationTokenSource tokenSource = new CancellationTokenSource();

        public static Task timerForGame(int waitPrRunSeconds, int secondsBeforeEnd, StartTask messageOnCountdown, EndTask timeRunOutTask)
        {
            Task task = new Task(() => {
                CancellationToken token = tokenSource.Token;


                for (int i = secondsBeforeEnd; i <= secondsBeforeEnd && i > -1 && !token.IsCancellationRequested; i--)
                {
                    if (i < secondsBeforeEnd && i > 0)
                    {
                        Task.Delay(waitPrRunSeconds * 1000).Wait();
                        if (!token.IsCancellationRequested)
                        {
                            messageOnCountdown();
                            Console.WriteLine(i + "\n");
                        }
                    }
                    else if (i <= 0)
                    {
                        Task.Delay(waitPrRunSeconds * 1000).Wait();
                        timeRunOutTask();
                    }
                }
            });
            task.Start();
            return task;
        }

        public static void stopTask()
        {
            tokenSource.Cancel();
        }

        public static void resetTokenValue()
        {
            tokenSource = new CancellationTokenSource();
        }
    }
}
