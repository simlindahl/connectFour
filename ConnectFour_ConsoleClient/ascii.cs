﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour_Server
{
    class ascii
    {

        public static void YouWin()
        {
            Console.WriteLine(
           " ██╗   ██╗ ██████╗ ██╗   ██╗    ██╗    ██╗ ██████╗ ███╗   ██╗██╗\n" +
            "╚██╗ ██╔╝██╔═══██╗██║   ██║    ██║    ██║██╔═══██╗████╗  ██║██║\n" +
            " ╚████╔╝ ██║   ██║██║   ██║    ██║ █╗ ██║██║   ██║██╔██╗ ██║██║\n" +
            "  ╚██╔╝  ██║   ██║██║   ██║    ██║███╗██║██║   ██║██║╚██╗██║╚═╝\n" +
            "   ██║   ╚██████╔╝╚██████╔╝    ╚███╔███╔╝╚██████╔╝██║ ╚████║██╗\n" +
            "   ╚═╝    ╚═════╝  ╚═════╝      ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═══╝╚═╝");

        }

        public static void StartScreen()
        {
            Console.WriteLine(
" ██████╗ ██████╗ ███╗   ██╗███╗   ██╗███████╗ ██████╗████████╗    ██╗  ██╗    ███████╗██╗   ██╗███╗   ██╗\n" +
"██╔════╝██╔═══██╗████╗  ██║████╗  ██║██╔════╝██╔════╝╚══██╔══╝    ██║  ██║    ██╔════╝██║   ██║████╗  ██║\n" +
"██║     ██║   ██║██╔██╗ ██║██╔██╗ ██║█████╗  ██║        ██║       ███████║    █████╗  ██║   ██║██╔██╗ ██║\n" +
"██║     ██║   ██║██║╚██╗██║██║╚██╗██║██╔══╝  ██║        ██║       ╚════██║    ██╔══╝  ██║   ██║██║╚██╗██║\n" +
"╚██████╗╚██████╔╝██║ ╚████║██║ ╚████║███████╗╚██████╗   ██║            ██║    ██║     ╚██████╔╝██║ ╚████║\n" +
" ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝ ╚═════╝   ╚═╝            ╚═╝    ╚═╝      ╚═════╝ ╚═╝  ╚═══╝\n"
                );
        }
    }
}