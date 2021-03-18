# -*- coding: utf-8 -*-
"""
Created on Thu Mar 18 11:52:41 2021

@author: TatThinhLe
"""

Array = [633, 276, 42, 597, 795, 879, 207, 489, 252, 153, 
         183, 651, 216, 351, 153, 531, 594, 420, 237, 963, 
         372, 555, 873, 939, 159, 795, 120, 90, 708, 630, 
         168, 489, 501, 456, 15, 258, 885, 297, 471, 660, 
         774, 1023, 402, 72, 537, 732, 6, 21, 492, 183]

def insertionSort(array):
    # begin with the 2nd element
    for currentIndex in range(1, len(array)):
        currentElement = array[currentIndex]
        previousIndex = currentIndex - 1
        # Insert this element into the sorted sequence array[0 ... j - 1]
        while previousIndex >= 0 and array[previousIndex] > currentElement:
            array[previousIndex + 1] = array[previousIndex]
            previousIndex = previousIndex - 1
        # previousIndex + 1: we already minus 1 in the while loop statement
        array[previousIndex + 1] = currentElement
    return array

print(insertionSort(Array))