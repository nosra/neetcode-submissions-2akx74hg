class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        hm = {}
        for num in nums:
            if num in hm:
                return True
            else:
                hm[num] = num
        return False
        