﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSharp
{
    class Learning_log
    {

    // well that is not my usual way of taking notes but anyway

    //i feel like this project idea is way advanced from my level now but i will try to keep it simple(perfectionism, calm down)
    //i made 3 function in ISKill for every skill to implement and i still don't know the logic completely but it will be string manipulation, analysis , and returning a response based on a previously written list of possible answers

    //chatbot is the class that is supposed to have instances of all skills and it will take the user input 
    and pass it on skills and continue with the flow

    //i keep everything simple by far. i got interface that all skills must implement, a chatbot that program.cs(my fronted here) will interact with, 
    and tommorrow i will add the logic on which the skill will decide if it can handle the input or not

    // tommorrow i will also change program.cs to give users previously written answers like: tell me a joke, what is the weather, what is the output of 2+6?
    just to make it easy for the chatbot because i have no real AI out there!!! 

    //i wrote a first version of canhandle function in joke skills and then started to refactor and think of better logic
      //first i split the input string and after using ToLower() ---> good idea
      //then i looped with for loop on the input words and for every word i used an if with very big condition statement to try to see
        // if the word is one of the possible words that implies a joke  ---> very bad because i kept adding || 

    //i made the code way better by introducing the HashSet concept ( i read about it first) and then i used a hash set called Trigger words 
    //instead of checking with if to decide the return, i used Any() operator to see if the word is in the TriggerWords hashset ---> so good isn't it


    }
}
