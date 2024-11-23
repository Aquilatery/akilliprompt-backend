namespace AkilliPrompt.WebApi.V1.Prompts;

public sealed record GetByIdPromptDto(
    Guid Id,
    string Title,
    string Description,
    string Content,
    string? ImageUrl,
    bool IsActive,
    ICollection<PromptCategoryDto> Categories,
    ICollection<PlaceholderDto> Placeholders);

public sealed record PromptCategoryDto(Guid Id, string Name);
public sealed record PlaceholderDto(Guid Id, string Name);