package ch7


data class Recipe1(val title : String, val isVegeterian: Boolean)

fun main() {
    val r1 = Recipe1("Thai Curry", false)
    val r2 = Recipe1("Thai Curry", false)
    val r3 = r1.copy(title = "Chicken Bhuna")

    println("r1 hash code: ${r1.hashCode()}")
    println("r2 hash code: ${r2.hashCode()}")
    println("r3 hash code: ${r3.hashCode()}")

    println("r1 toString: ${r1.toString()}")

    println("r1 ==r2? ${r1==r2}")
    println("r1===r2? ${r1===r2}")
    println("r1 == r3? ${r1==r3}")

    val (title,vegetarian) = r1
    println("title is $title and vegetarian is $vegetarian")
}