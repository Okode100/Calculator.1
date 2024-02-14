def func(**kwargs):
    if "zero" in kwargs:
        print(kwargs["zero"])
    else:
        print("key 'zero' not found in kwargs")
func(zero=42, one=23, two=10)        