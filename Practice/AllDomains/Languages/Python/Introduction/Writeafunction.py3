#/*	author:@shivkrthakur  */
def is_leap(year):
    leap = False
    if year % 4 == 0:
        if year % 100 != 0:
            leap = True
        else:
            if year % 400 == 0:
                leap = True
    # Write your logic here
    
    return leap