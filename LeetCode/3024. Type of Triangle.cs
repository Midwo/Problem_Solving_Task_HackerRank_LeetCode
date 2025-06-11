using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3024
    {
        ////(3024.) Type of Triangle (EASY)
        public string TriangleType(int[] nums)
        {
            if (nums[0] == nums[1] && nums[0] == nums[2])
            {
                return "equilateral";
            }
            else if (nums[0] == nums[1] || nums[1] == nums[2] || nums[0] == nums[2])
            {
                if (IsTriangle(nums))
                {
                    return "isosceles";
                }
                else
                {
                    return "none";
                }
            }
            else
            {
                if (IsTriangle(nums))
                {
                    return "scalene";
                }
                else
                {
                    return "none";
                }
            }
        }

        public bool IsTriangle(int[] nums)
        {
            if (nums[0] <= nums[1] && nums[0] <= nums[2])
            {
                if (nums[1] <= nums[2])
                {
                    if (nums[2] < nums[1] + nums[0])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (nums[1] < nums[0] + nums[2])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (nums[1] <= nums[2] && nums[1] <= nums[0])
            {
                if (nums[0] <= nums[2])
                {
                    if (nums[2] < nums[0] + nums[1])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (nums[0] < nums[1] + nums[2])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                if (nums[1] <= nums[0])
                {
                    if (nums[0] < nums[1] + nums[2])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (nums[1] < nums[0] + nums[2])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
