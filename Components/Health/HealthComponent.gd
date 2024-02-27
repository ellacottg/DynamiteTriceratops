extends Node2D
class_name HealthComponent

@export var MAX_HEALTH : int
var health : int

@export var item_drop : PackedScene

func _ready():
	health = MAX_HEALTH
	
func damage(attack: float):
	health -= attack
	
	if health <= 0:
		if item_drop:
			var instance = item_drop.instantiate()
			get_parent().get_parent().add_child(instance)
			instance.position = get_parent().position
		
		get_parent().queue_free()
		
		
