def is_even(x):
    if x  % 2 == 0:
        return True
    def is_odd(x):
        if x == 1:
            return False 
        else:
            return is_even(x-1)
        
         
    