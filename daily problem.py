
def count_candels(candels):
  tallest = max(candels)
  return candels.count(tallest)

user_input = input("enter the hieght of candels:")
candels = list(map(int,user_input.split()))
print("the num of the tallest candels is : ", count_candels(candels))