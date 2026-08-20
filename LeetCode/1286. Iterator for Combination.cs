using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1286
    {
        ////(1286.) Iterator for Combination (MEDIUM)
        public class CombinationIterator
        {
            int[] _combinationIndex;
            char[] _currCombination;
            int _length;
            bool _hasNext;
            string _characters;
            int _countCharacters;
            public CombinationIterator(string characters, int combinationLength)
            {
                _countCharacters = characters.Length;
                _characters = characters;
                _length = combinationLength;
                _combinationIndex = new int[_length];
                _currCombination = new char[_length];
                for (int i = 0; i < _length; i++)
                {
                    _combinationIndex[i] = i;
                    _currCombination[i] = characters[i];
                }
                _hasNext = true;
            }

            public string Next()
            {
                if (!_hasNext)
                {
                    return string.Empty;
                }

                string resultCombination = new string(_currCombination);
               
                if(_length == 1)
                {
                    if(_combinationIndex[0] +1 < _countCharacters)
                    {
                        _combinationIndex[0] = _combinationIndex[0] + 1;
                        _currCombination[0] = _characters[_combinationIndex[0]];
                        return new string(resultCombination);
                    }
                    else 
                    { 
                        _hasNext = false;
                        return resultCombination;
                    }
                }

                bool correct = false;

                for (int index = _length - 1; index >= 0; index--)
                {
                    if (_combinationIndex[index] + 1 >= _countCharacters)
                    {
                        continue;
                    }
                    else
                    {
                        _combinationIndex[index]++;
                        _currCombination[index] = _characters[_combinationIndex[index]];

                        bool generationFailed = false;
                        int nextCharsIndex = _combinationIndex[index]+1;

                        for (int i = index + 1; i < _length; i++)
                        {
                            if (nextCharsIndex >= _countCharacters)
                            {
                                generationFailed = true;
                                break;
                            }

                            _combinationIndex[i] = nextCharsIndex;
                            _currCombination[i] = _characters[nextCharsIndex];
                            nextCharsIndex++;
                        }
                        if (!generationFailed)
                        {
                            correct = true;
                            break;
                        }
                    }
                }

                if (!correct)
                {
                    _hasNext = false;
                }

                return new string(resultCombination);
            }

            public bool HasNext()
            {
                return _hasNext;
            }
        }
    }
}
