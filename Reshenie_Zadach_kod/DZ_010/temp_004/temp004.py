a = int(input())
b = int(input())
c = int(input())
if c <= b * a and (c % a == 0 or c % b == 0):
    print('yes')
else:
    print('no')
