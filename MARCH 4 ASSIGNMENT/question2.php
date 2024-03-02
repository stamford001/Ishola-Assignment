<?php

    function smallestIndex(array $array, int $size) : int {
        $min = min($array);
        
        return array_search($min, $array);
    }

    $array = [99, 884, 4774, 8, 474, 94];
    $smallestIndex = smallestIndex($array, count($array));

    echo "Smallest index is $smallestIndex";