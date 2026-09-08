using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TreeImplementation;
using TreeImplementation.TreeTraversal.Implementation.DepthFirst.implementation;

namespace SpellChecker
{
    public class SpellCheckerService
    {
        private BinarySearchTreeImplementation<string> _dictionary;
        private InOrderTraversal<string> _traversal;

        public SpellCheckerService(string dictionaryPath)
        {
            _dictionary = new BinarySearchTreeImplementation<string>();
            _traversal = new InOrderTraversal<string>();
            LoadDictionary(dictionaryPath);
        }

        private void LoadDictionary(string path)
        {
            foreach (var word in File.ReadAllLines(path))
                _dictionary.insert(word.ToLower().Trim());
        }

        public bool IsCorrect(string word) => _dictionary.Search(word.ToLower());

        public List<string> GetSuggestions(string typo, int max = 3)
        {
            var allWords = _traversal.Traverse(_dictionary);
            return allWords
               .Where(w => w.Length == typo.Length) // Hamming only works same length
               .OrderBy(w => LevenshteinDistance(typo, w))
               .Take(max)
               .ToList();
        }

        private int LevenshteinDistance(string s, string t)
        {
            int[,] d = new int[s.Length + 1, t.Length + 1];
            for (int i = 0; i <= s.Length; i++) d[i, 0] = i;
            for (int j = 0; j <= t.Length; j++) d[0, j] = j;

            for (int i = 1; i <= s.Length; i++)
                for (int j = 1; j <= t.Length; j++)
                {
                    int cost = (s[i - 1] == t[j - 1]) ? 0 : 1;
                    d[i, j] = Math.Min(Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1), d[i - 1, j - 1] + cost);
                }
            return d[s.Length, t.Length];
        }
    }
}