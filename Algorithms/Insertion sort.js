var Array = [1553, 952, 1556, 1685, 83, 1123];

function insertionSort(array) {
    // begin with the 2nd element
    for (let currentIndex = 1; currentIndex < array.length; currentIndex++) {
        let currentElement = array[currentIndex];
        let previousIndex = currentIndex - 1;
        // Insert this element into the sorted sequence array[0 ... j - 1]
        while (previousIndex >= 0 && array[previousIndex] > currentElement) {
            array[previousIndex + 1] = array[previousIndex];
            previousIndex = previousIndex - 1;
        }
        // previousIndex + 1: get back to the correct element's position
        array[previousIndex + 1] = currentElement;
    }
    return array
}

console.log(insertionSort(Array));