package main

func floodFill(image [][]int, sr int, sc int, color int) [][]int {
	_floodFill(image, sr, sc, color, image[sr][sc])
	return image
}

func _floodFill(image [][]int, sr int, sc int, color int, startVal int) {
	image[sr][sc] = color
	if sr > 0 && image[sr-1][sc] == startVal && image[sr-1][sc] != color {
		_floodFill(image, sr-1, sc, color, startVal)
	}
	if sr < len(image)-1 && image[sr+1][sc] == startVal && image[sr+1][sc] != color {
		_floodFill(image, sr+1, sc, color, startVal)
	}
	if sc > 0 && image[sr][sc-1] == startVal && image[sr][sc-1] != color {
		_floodFill(image, sr, sc-1, color, startVal)
	}
	if sc < len(image[0])-1 && image[sr][sc+1] == startVal && image[sr][sc+1] != color {
		_floodFill(image, sr, sc+1, color, startVal)
	}
}
