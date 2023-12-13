def twoSum(nums: list[int], target: int) -> list[int]:
    result = []
    for i in range(len(nums)):
        for j in range(i + 1, len(nums)):
            # print(f"i - {i}   j - {j}")
            if nums[i] + nums[j] == target:
                return [i, j]

        
print(twoSum(nums=[2,7,11,15], target=9))
# [3, 2, 3] - 6
# [3, 3] - 6
# [3, 2, 4] - 6
# [2,7,11,15] - 9