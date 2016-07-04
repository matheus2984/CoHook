using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using CoHook.Enum;
using CoHook.Extentions.Threading;
using CoHook.Hook;
using System.Diagnostics;

namespace CoHook.Functions
{
    public class AutoPot
    {
        private ThreadAction autoPotThread;
        private ThreadAction keyCheckThread;
        private ThreadAction dequeueThread;

        private readonly Queue<VKCode> keyQueue;

        private readonly VKCode[] codeToCheck =
        {
            VKCode.F3, VKCode.F4, VKCode.F5, VKCode.F6,
            VKCode.F7, VKCode.F8, VKCode.F9, VKCode.F10, VKCode.F11, VKCode.F12
        };

        private VKCode lastCode;

        [DllImport("user32.dll")]
        private static extern short GetKeyState(VKCode nVirtKey);


        private static object SyncRoot = new object();
  
        private static int threadInControl = 1;

      
        public static void WaitTurn(int threadNum)
        {
            while (threadInControl != threadNum)
            {
                Monitor.Wait(SyncRoot);
            }
        }

        public static void GiveTurnTo(int nextThreadNum)
        {
            threadInControl = nextThreadNum;
            Monitor.Pulse(SyncRoot);
        }



        public AutoPot()
        {
            keyQueue = new Queue<VKCode>();
         //   autoPotThread = ThreadAction.Factory(AutoPotThread, 100, true);
         //   keyCheckThread = ThreadAction.Factory(KeyCheckThread, 10, true);
         //   dequeueThread = ThreadAction.Factory(DequeueCheckThread, 10, true);
        }

 

        private void AutoPotThread()
        {
       //     lock (SyncRoot)
         //   {
                if (!Client.FocusCheck()) return;

                KeyboardHook.SendKey(VKCode.F1, VKState.Pressed);
                KeyboardHook.SendKey(VKCode.F2, VKState.Released);
                Thread.Sleep(50);

                KeyboardHook.SendKey(VKCode.F2, VKState.Pressed);
                KeyboardHook.SendKey(VKCode.F1, VKState.Released);
                Thread.Sleep(50);

           //     GiveTurnTo(3);
           //     WaitTurn(1);
         //   }
        }

        private void KeyCheckThread()
        {
            lock (SyncRoot)
            {
                foreach (var code in codeToCheck)
                {
                    KeyState(code);
                }
            }
        }

        private void DequeueCheckThread()
        {
            lock (SyncRoot)
            {
                WaitTurn(3);

                Console.WriteLine("Dequeue");
                int startCount = keyQueue.Count;
                if (startCount > 0)
                {
                    var code = keyQueue.Dequeue();
                    KeyboardHook.SendKey(code, VKState.Pressed);
                }
                keyQueue.Clear();

                GiveTurnTo(1);
                GiveTurnTo(2);
            }
        }

        private void KeyState(VKCode code)
        {
            if (!Client.FocusCheck()) return;
            short result = GetKeyState(code);

            switch (result)
            {
                default:
                    if (code != lastCode)
                    {
                        lock (keyQueue)
                        {
                            if (keyQueue.Contains(code)) return;
                            if (lastCode == code) return;

                            Console.WriteLine("Enqueue: " + code);
                            keyQueue.Enqueue(code);
                        }
                        lastCode = code;
                    }

                    break;
            }
        }

        private Stopwatch sp;
        public void Enable(bool value)
        {
            var trh = new Thread(() =>
            {
                while (true)
                {

                    if (!Client.FocusCheck()) continue;

                 //   sp = Stopwatch.StartNew();
                    KeyboardHook.SendKey(VKCode.SPACE, VKState.Pressed);
                    KeyboardHook.SendKey(VKCode.F1, VKState.Pressed);
                //    KeyboardHook.SendKey(VKCode.F1, VKState.Released);
                  //  KeyboardHook.SendKey(VKCode.SPACE, VKState.Pressed);
                   // KeyboardHook.SendKey(VKCode.F2, VKState.Released);
                    Thread.Sleep(1);// - (int)sp.ElapsedMilliseconds);

                  //  Console.WriteLine(sp.ElapsedMilliseconds);
                   // sp.Reset();
                 //   KeyboardHook.SendKey(VKCode.F2, VKState.Pressed);
                //    KeyboardHook.SendKey(VKCode.F1, VKState.Released);
                  //  Thread.Sleep(10);// - (int)sp.ElapsedMilliseconds);
                }
            });
            trh.IsBackground = true;
            trh.Start();
            return;
          /*  if (value)
            {
                if (autoPotThread == null)
                {
                    autoPotThread = ThreadAction.Factory(AutoPotThread, 1, true);

                    var trh = new Thread(() =>
                    {
                        while (true)
                        {
                            sp = Stopwatch.StartNew();
                            if (!Client.FocusCheck()) return;

                            KeyboardHook.SendKey(VKCode.F1, VKState.Pressed);
                            Thread.Sleep(100 - (int)sp.ElapsedMilliseconds);
                            sp.Reset();
                            KeyboardHook.SendKey(VKCode.F2, VKState.Pressed);
                            Thread.Sleep((100 - (int)sp.ElapsedMilliseconds));
                        }
                    });
                    trh.IsBackground = true;
                    trh.Start();
                    keyCheckThread = ThreadAction.Factory(KeyCheckThread, 10, true);
                    dequeueThread = ThreadAction.Factory(DequeueCheckThread, 10, true);
                }
            }
            else
            {
                autoPotThread.CloseThread();
                keyCheckThread.CloseThread();
                dequeueThread.CloseThread();
            }*/
        }
    }
}