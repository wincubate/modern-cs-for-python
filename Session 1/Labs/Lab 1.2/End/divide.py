def divide(x,y):
    try:
        result = x/y
    except ZeroDivisionError:
        print("Please make 'y' non-zero")
    except:
        print("Something went wrong")
    else:
        print(f"Your answer is {result}")
    finally:
        print("Aaaaand... We're done!")
