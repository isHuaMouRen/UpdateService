const { Octokit } = require('@octokit/core');

async function autoMerge() {
    const octokit = new Octokit({ auth: process.env.GITHUB_TOKEN });
    const prNumber = process.env.PR_NUMBER;
    const owner = process.env.REPO_OWNER;
    const repo = process.env.REPO_NAME;

    // 验证输入
    if (!prNumber || !owner || !repo) {
        console.error('Missing required environment variables: PR_NUMBER, REPO_OWNER, or REPO_NAME');
        process.exit(1);
    }

    try {
        // 获取 PR 信息
        const { data: pr } = await octokit.request('GET /repos/{owner}/{repo}/pulls/{pull_number}', {
            owner,
            repo,
            pull_number: prNumber
        });

        // 检查 PR 是否可合并
        if (pr.mergeable && !pr.draft && pr.state === 'open') {
            // 自动合并 PR
            await octokit.request('PUT /repos/{owner}/{repo}/pulls/{pull_number}/merge', {
                owner,
                repo,
                pull_number: prNumber,
                commit_title: `Auto-merge PR #${prNumber}`,
                commit_message: 'Automatically merged by GitHub Actions',
                merge_method: 'merge'
            });
            console.log(`PR #${prNumber} successfully merged`);
        } else {
            console.log(`PR #${prNumber} not merged: Not mergeable, is draft, or not open`);
        }
    } catch (error) {
        console.error('Error:', error.message);
        process.exit(1);
    }
}

autoMerge();