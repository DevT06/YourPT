﻿using Shared.AbstractEntities;

namespace Shared.Entities;

public class AssignmentReflection : Reflection
{
	public Assignment Assignment { get; set; }
	//FK
	public int? AssignmentId {get; set; }

	//Todo rethink reflections (add in mongo db) and or make Assignment or goal can have multiple
}