extends Node2D
class_name HealthComponent

@export var MAX_HEALTH : int
var health : int

func _ready():
	health = MAX_HEALTH
	
func damage(attack: float):
	health -= attack
	
	if health <= 0:
		get_parent().queue_free()
