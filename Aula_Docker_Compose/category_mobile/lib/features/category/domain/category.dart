class Category {
  final int categoryEntityId;
  final String name;
  final String description;

  Category(
      {required this.categoryEntityId,
      required this.name,
      required this.description});

  factory Category.fromJson(Map<String, dynamic> json) {
    return Category(
      categoryEntityId: json['categoryEntityId'],
      name: json['name'],
      description: json['description'],
    );
  }

  Map<String, dynamic> toJson() {
    return {
      'categoryEntityId': categoryEntityId,
      'name': name,
      'description': description,
    };
  }

  Category copyWith({
    int? categoryEntityId,
    String? name,
    String? description,
  }) {
    return Category(
      categoryEntityId: categoryEntityId ?? this.categoryEntityId,
      name: name ?? this.name,
      description: description ?? this.description,
    );
  }
}
