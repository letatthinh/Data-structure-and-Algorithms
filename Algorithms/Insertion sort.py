# -*- coding: utf-8 -*-
"""
Created on Thu Mar 18 11:52:41 2021

@author: TatThinhLe
"""

Array = [1553, 952, 1556, 1685, 83, 1123]

def insertionSort(array):
    # begin with the 2nd element
    for currentIndex in range(1, len(array)):
        currentElement = array[currentIndex]
        previousIndex = currentIndex - 1
        # Insert this element into the sorted sequence array[0 ... j - 1]
        while previousIndex >= 0 and array[previousIndex] > currentElement:
            array[previousIndex + 1] = array[previousIndex]
            previousIndex = previousIndex - 1
        # previousIndex + 1: get back to the correct element's position
        array[previousIndex + 1] = currentElement
    return array

print(insertionSort(Array))