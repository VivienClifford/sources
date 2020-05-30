﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordUnscrambler.Workers;

namespace WordUnscrambler.Test.Unit
{
    [TestClass]
    public class WordMatcherTest
    {
        private readonly WordMatcher wordMatcher = new WordMatcher();

        [TestMethod]
        public void ScrambledWordMatchesWordInTheList()
        {
            string[] words = { "cat", "chair", "more" };
            string[] scrambledWords = { "orme" };

            var matchedWords = wordMatcher.Match(scrambledWords, words);

            Assert.IsTrue(matchedWords.Count == 1);
            Assert.IsTrue(matchedWords[0].ScrambledWord.Equals("orme"));
            Assert.IsTrue(matchedWords[0].Word.Equals("more"));
        }

        [TestMethod]
        public void ScrambledWordMatchesGivenWordsInTheList()
        {
            string[] words = { "cat", "chair", "more" };
            string[] scrambledWords = { "orme", "act" };

            var matchedWords = wordMatcher.Match(scrambledWords, words);

            Assert.IsTrue(matchedWords.Count == 2);
            Assert.IsTrue(matchedWords[0].ScrambledWord.Equals("orme"));
            Assert.IsTrue(matchedWords[0].Word.Equals("more"));
            Assert.IsTrue(matchedWords[1].ScrambledWord.Equals("act"));
            Assert.IsTrue(matchedWords[1].Word.Equals("cat"));
        }
    }
}
