namespace DefaultNamespace;

public class Solution 
{
    public int Trap(int[] height) 
    {
        if (height == null || height.Length < 3) return 0;
        
        int left = 0;
        int right = height.Length - 1;
        int leftMax = 0;
        int rightMax = 0;
        int water = 0;
        
        while (left < right) 
        {
            if (height[left] < height[right]) 
            {
                // Water at left is limited by leftMax
                leftMax = Math.Max(leftMax, height[left]);
                water += leftMax - height[left];
                left++;
            } 
            else 
            {
                // Water at right is limited by rightMax
                rightMax = Math.Max(rightMax, height[right]);
                water += rightMax - height[right];
                right--;
            }
        }
        return water;
    }
}